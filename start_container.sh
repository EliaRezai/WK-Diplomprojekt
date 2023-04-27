DOCKER_IMAGE=physiotool_webapp
# Generate random secret (the secret in appsettings.json is empty)
SECRET=$(dd if=/dev/random bs=128 count=1 2> /dev/null | base64)
CERT_PASS=$(dd if=/dev/random bs=128 count=1 2> /dev/null | base64)
CWD=$(pwd)
BRANCH=$(git branch --show-current)

read -p "$(echo -e "Build app from branch ${YELLOW}$BRANCH${NC}. Press to continue or CTRL+C to cancel building.")"

rm $USERPROFILE/.aspnet/https/physiotool.pfx
dotnet dev-certs https -ep $HOME/.aspnet/https/physiotool.pfx -p "$CERT_PASS"
dotnet dev-certs https --trust

# Cleanup
docker rm -f $DOCKER_IMAGE
docker volume prune -f
docker image prune -f

# Build and run app container with certificate.
# See https://learn.microsoft.com/en-us/aspnet/core/security/docker-https?view=aspnetcore-7.0
cd "$CWD/Frontend"
rm -rf node_modules
npm install && npm run build
if [ $? -ne 0 ]; then
    echo "Error building the Vue.js application in $CWD/Frontend with npm run build."
    exit 1
fi
cd "$CWD/Backend"
docker build -t $DOCKER_IMAGE . 
MSYS_NO_PATHCONV=1 docker run -d -p 6000:80 -p 6001:443 --name $DOCKER_IMAGE \
    -e "ASPNETCORE_URLS=https://+;http://+" \
    -e "ASPNETCORE_HTTPS_PORT=6001" \
    -e ASPNETCORE_Kestrel__Certificates__Default__Password="$CERT_PASS" \
    -e ASPNETCORE_Kestrel__Certificates__Default__Path="/https/physiotool.pfx" \
    -e "ASPNETCORE_ENVIRONMENT=Production" \
    -e "SECRET=$SECRET" \
    -v $USERPROFILE/.aspnet/https:/https/ \
    $DOCKER_IMAGE
cd "$CWD"

echo "Container startet. Check https://localhost:6001 in your browser."