<template>
    <div class="terminView">
        <h1>Termin buchen</h1>
        <h2>Todo</h2>
        <ul>
            <li>Der Patient <strong>muss sich nicht anmelden</strong>, um einen Termin zu buchen!</li>
            <li>Es wird wie auf https://www.ortho-zentrum.at/#termin eine Ansicht mit Zeitraster generiert.</li>
            <li>Der Patient klickt auf Reservieren. Danach wird nach Name, Vorname, Email und Telefonnummer gefragt.</li>
            <li>Nach der Eingabe wird der Datensatz als Appointment im Backend gespeichert.</li>
            <li>Optional: Eine Email mit der Bestätigung wird versandt. Zum Absagen kann ein entsprechender
                Link mitgeschickt werden. Das ist aber nicht so einfach, da hierfür ein Mailserver
                benötigt wird.
            </li>
        </ul>
    </div>
</template>