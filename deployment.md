# Deployment der Applikation in Microsoft Azure

## Voraussetzungen

Lade das Azure Command Line Tool von https://learn.microsoft.com/en-us/cli/azure/install-azure-cli.
Gib danach in der Konsole den Befehl `az login` ein, um das Tool mit deinem Login zu verbinden.

## Testen des Containers

Die App wird als Docker Container in die Azure Container Registry übertragen.
Dieser Container wird im Azure App Service gestartet.
Deswegen ist es wichtig, dass du vorher die Applikation als Container im Production Mode testest.
Gehe dafür in das Hauptverzeichnis des Repositories und öffne **die git bash**.
Führe danach mit `./start_container.sh` das Buildskript aus.
Die Applikation wird nun unter *https://localhost:6001* bereitgestellt und muss funktionieren.

## Upload des Containers

Starte **in der git bash** das Skript `./deploy_app.sh` und folge den Anweisungen.

> **Achtung:** Die App wird im Standard Plan (S1) erstellt.
> Dieser kostet 64 EUR pro Monat.
> Gehe daher auf *https://portal.azure.com* in die Ressourcengruppe und dann auf den App Service plan.
> Mit *Scale up* kannst du die App in den Free Plan oder in einen billigeren Plan versetzen.
> Es kann 1-2 Minuten dauern, bis die App bereitgestellt wird.
> In dieser Zeit werden 500er Fehler zurückgegeben, obwohl nichts falsch ist.
