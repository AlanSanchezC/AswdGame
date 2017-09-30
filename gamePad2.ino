#include <Keyboard.h>

int btnIzquierda = 3;
int btnArriba = 4;
int btnAbajo = 5;
int btnDerecha = 6;

int state = 1;

void setup() {
  pinMode(btnIzquierda, INPUT_PULLUP);
  pinMode(btnArriba, INPUT_PULLUP);
  pinMode(btnAbajo, INPUT_PULLUP);
  pinMode(btnDerecha, INPUT_PULLUP);
  Keyboard.begin();
}

void loop(){
  state = digitalRead(btnIzquierda);
  
  if (state != 1){
    Keyboard.write('a');
    delay(250);
  }

  state = digitalRead(btnArriba);
  
  if (state != 1){
    Keyboard.write('w');
    delay(250);
  }

  state = digitalRead(btnAbajo);
  
  if (state != 1){
    Keyboard.write('s');
    delay(250);
  }

  state = digitalRead(btnDerecha);
  
  if (state != 1){
    Keyboard.write('d');
    delay(250);
  }
}


