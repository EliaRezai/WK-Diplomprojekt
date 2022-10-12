(() => {
    if('indexedDb' in window){
        console.log("Dein Browser supported keine IndexedDB Datenbank");
        return;
    }
})();

const indexedDB =
    window.indexedDB ||
    window.mozIndexedDB ||
    window.webkitIndexedDB ||
    window.msIndexedDB ||
    windows.shimIndexedDB;

function AddData() {
    const dbname = "PVTDB";
    const request = window.indexedDB.open(dbname);
    request.onerror = function(e) {
        console.log("Error opening db");
      
        };

    request.onupgradeneeded = function () {
    const db = request.result;
    if(!thisDb.objectStoreNames.contains("User")) {
    const store = db.createObjectStore("User", { keyPath: "id", autoIncreament : true});
    }
    store.createIndex("Vorname", {unique: false});
    store.createIndex("Nachname", {unique: false});
    store.createIndex("EMail", {unique: true});
    store.createIndex("Passwort", {unique: false});
    store.createIndex("Strasse", {unique: false});
    store.createIndex("PLZ", {unique: false});
    store.createIndex("Ort", {unique: false});
    store.createIndex("SVNR", {unique: true});
    store.createIndex("Geburtsdatum", {unique: true});
};

 request.onsuccess = function(event) {
    db = event.target.result;
    console.log("Erfolgreich: "+ db);
    alert( "Tom wurde zur Datenbank hinzugefügt!.");
 };

 request.onerror = function(event) {
    console.log("error: " + event.target.errorCode);
    alert("Fehler beim hinzufügen der Person");
 };
 CheckUser();


 function CheckUser(){
	db.transaction(["User"],"readonly").objectStore("User").count().onsuccess = function(event) {
    var authc= event.target.result;
      if(authc ==0)
      {
       add();
      }
	    };
    }


    function Add(){

        var transaction = db.transaction(["User"], "readwrite")
        .objectStore("User").add({id: "00001", vorname: "Tom", nachname : "Müller", geburtsdatum: 22-03-2001, email: "kenny@planet.org", 
        passwort: "Tom123", strasse: "Linzerstrasse 110/2", plz: "1140", ort: "Wien", svnr: "4102220301"});
       
       
         var transaction = db.transaction(["User"]);
         var objectStore = transaction.objectStore("User");
         var request = objectStore.get(1);
         
          
        
        

         request.onsuccess = function(event) {
            
            if(request.result) {
              if(request.result.Email == Credential.email && request.result.passwort == Credential.passwort){
                GetAgents();
              }
              else{
                $scope.ErrorMessage = "Geben Sie gültige Anmeldeinformationen ein!!!"
                $scope.$apply($scope.tooltipIsOpen = true);
              }
            }               
            else {
              $scope.ErrorMessage = "Kein Patient verfügbar!!!"
                $scope.$apply($scope.tooltipIsOpen = true);
            }
         };
    
 }

 






        




}
