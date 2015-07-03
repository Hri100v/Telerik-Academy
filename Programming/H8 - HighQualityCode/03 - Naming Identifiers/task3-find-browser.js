function onClickCheckBrowser(event, arguments) {
  var myOperationSystem = window,
      browser = myOperatingSystem.navigator.appCodeName,
      isMozilla = (browser === "Mozilla");

  if(isMozilla) {
    alert("Yes");
  } else {
    alert("No");
  }
}
