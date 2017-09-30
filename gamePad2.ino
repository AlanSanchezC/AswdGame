//Hecho por: Alan Sánchez Cazarez

//Se necesita la librería Keyboard.h (Solo Arduino Leonardo, Micro o Due)
#include <Keyboard.h>

int btnIzquierda = 3; //Pin digital 3
int btnArriba = 4; //Pin digital 4
int btnAbajo = 5; //Pin digital 5
int btnDerecha = 6; //Pin digital 6

int state = 1;

void setup() {
  /*
  Modo INPUT_PULLUP para detectar los pulsos BAJOS
  */
  pinMode(btnIzquierda, INPUT_PULLUP);
  pinMode(btnArriba, INPUT_PULLUP);
  pinMode(btnAbajo, INPUT_PULLUP);
  pinMode(btnDerecha, INPUT_PULLUP);
  Keyboard.begin();
}

void loop(){
  //Se detecta el estado del pin (0 ó 1)
  state = digitalRead(btnIzquierda);
  
  //Siempre estará en 1 (ALTO), pero al presionar el botón, dará un pulso 0 (BAJO)
  if (state != 1){
    Keyboard.write('a');
    delay(250);
  }

  //Mismo código para todas las teclas
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
