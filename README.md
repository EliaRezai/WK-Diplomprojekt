# PVT Physiotherapie Verwaltungstool

| Name                   | Individuelle Themenstellung                                                    | Klasse |
| ---------------------- | ------------------------------------------------------------------------------ | ------ |
| **Elia Rezai**         | (Hier die Themenstellung von diplomarbeiten.berufsbildendeschulen.at kopieren) | 5CAIF  |
| Dean-Christoph Neuhold | (Hier die Themenstellung von diplomarbeiten.berufsbildendeschulen.at kopieren) | 5CAIF  |
| Dean Nikolic           | (Hier die Themenstellung von diplomarbeiten.berufsbildendeschulen.at kopieren) | 5CAIF  |

Betreuender Lehrer: Maximilian Kraft (KRM)

## Klonen des Repos

```
git clone https://github.com/EliaRezai/WK-Diplomprojekt
```

## Starten des ASP.NET Core Webservers

Führe die Datei *Backend/startDevServer.cmd* (Windows) bzw. *Backend/start_dev_server.sh* (macOS, Linux) aus.
Es startet mit *dotnet watch run* die ASP.NET Core Applikation in *Backend/Physiotool.Webapi*.
Der ASP.NET Core Webserver liefert die HTML Seite in *wwwroot/index.html* aus. Die API ist unter
der Route */api/(controller)* erreichbar.

### Build der Vue.js Applikation

Damit die Webapi das Frontend ausliefert, muss ein Build des Frontends erstellt werden. Gehe
in den Ordner *Frontend* und führe die folgenden Befehle aus:
```
npm install
npm run build
```
