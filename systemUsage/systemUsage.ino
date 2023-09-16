#include <LiquidCrystal.h>
String s;
int loc[3];
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
void setup() {
  lcd.begin(16, 2);
  Serial.begin(9600);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Starting...");
  delay(1000);
  lcd.clear();
  Serial.begin(9600);
}

void loop() {
  int x=0;
  if (Serial.available() > 0) {
    s = Serial.readString();
    for(int i=0; i<s.length()-1; i++){
      if(s[i]==' '){
        loc[x]=i;
        x++;
      }

    }
  Serial.println(s);
  Serial.print(loc[0]);
  Serial.print(loc[1]);
  Serial.println(loc[2]);
  Serial.println(s.length());
  lcd.setCursor(0, 0);
  lcd.write("CPU RAM GPU BAT");

  lcd.setCursor(0,1);
  lcd.print("    ");
  lcd.setCursor(0,1);
  lcd.print(s.substring(0, loc[0]));
  
  lcd.setCursor(4,1);
  lcd.print("    ");
  lcd.setCursor(4,1);
  lcd.print(s.substring(loc[0]+1, loc[1]));

  lcd.setCursor(8,1);
  lcd.print("    ");
  lcd.setCursor(8,1);
  lcd.print(s.substring(loc[1]+1, loc[2]));

  lcd.setCursor(12,1);
  lcd.print("    ");
  lcd.setCursor(12,1);
  lcd.print(s.substring(loc[2]+1, s.length()-1));
  lcd.print("     ");

  }
}
