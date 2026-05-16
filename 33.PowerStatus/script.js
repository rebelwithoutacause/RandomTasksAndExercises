let isDay = false;
let isLightOn = !isDay;
let batteryLevel = 50;
let print = "%";

function update() {
  isLightOn = !isDay;
  const isWorking = isLightOn === true && batteryLevel > 0;

  document.body.className = isDay ? 'day' : 'night';
  document.getElementById('bulb').className           = 'bulb ' + (isLightOn ? 'on' : 'off');
  document.getElementById('light-status').textContent = isLightOn ? 'ON' : 'OFF';
  document.getElementById('battery-fill').style.width = batteryLevel + print;
  document.getElementById('battery-text').textContent = batteryLevel + print;

  const ws = document.getElementById('working-status');
  ws.textContent = isWorking ? 'Yes' : 'No';
  ws.className   = 'value ' + (isWorking ? 'status-yes' : 'status-no');

  console.log("Daytime?",            isDay);
  console.log("Lights on?",          isLightOn);
  console.log("Battery level?",      batteryLevel + print);
  console.log("Everything working?", isWorking);
}

document.querySelectorAll('input[name="time"]').forEach(function (radio) {
  radio.addEventListener('change', function () {
    isDay = this.value === 'day';
    update();
  });
});

update();
