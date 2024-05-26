#define blueBtn 5
#define whiteBtn 4
#define redBtn 7
#define SCK A5
#define SDA A4
#define ButtonDelay 2000

#include <EncButton.h>

Button blueB(blueBtn);
Button whiteB(whiteBtn);
Button redB(redBtn);

void setup() {
  Serial.begin(9600);
  Serial.print("1rC");
}

void loop() {
  blueB.tick();
  whiteB.tick();
  redB.tick();

  if(blueB.press()) {
    Serial.println("1p");
  }
  if(blueB.release()) {
    Serial.println("1r");
  }
  if(redB.press()) {
    Serial.println("2p");
  }
  if(redB.release()) {
    Serial.println("2r");
  }
  if(whiteB.press()) {
    Serial.println("3p");
  }
  if(whiteB.release()) {
    Serial.println("3r");
  }
}
