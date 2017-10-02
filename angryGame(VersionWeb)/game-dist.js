;(function(){

	class Go
	{
		constructor(img){
			this.x = 0
			this.y = 0
			this.size = 40
			this.draw(img)		
		}

		getX(){
			return this.x;
		}

		getY(){
			return this.y;
		}

		right(){
			if(this.x == 920){
				var s = new Audio('guau1.mp3');
				s.play();
				this.x = 0
			}
			else
				this.x += this.size
		}

		left(){
			if (this.x == 0){
				var s = new Audio('guau2.mp3');
				s.play();
				this.x = 920
			}
			else
				this.x -= this.size
		}

		up(){
			if (this.y == 0){
				var s = new Audio('guau1.mp3');
				s.play();
				this.y = 480
			}
			else
				this.y -= this.size
		}

		down(){
			if (this.y == 480){
				var s = new Audio('guau2.mp3');
				s.play();
				this.y = 0
			}
			else
				this.y += this.size
		}

		draw(img){
			ctx.drawImage(img, this.x, this.y, this.size, this.size);
		}
	}

	function dibujar(imagen, anchoCanvas, altoCanvas){
		ctx.fillRect(0,0, anchoCanvas, altoCanvas);
		go.draw(imagen)
	}

	const canvas = document.getElementById('canvas')
	const ctx = canvas.getContext('2d')
	ctx.fillStyle = "#ffffcc"
	
	var enoja = document.getElementById('imagen');
	const go = new Go(enoja)
	
	dibujar(enoja, canvas.width, canvas.height);

	window.addEventListener("keydown", function(event){
		if (event.keyCode > 87 && event.keyCode < 65) event.preventDefault()

		if (event.keyCode === 83) go.down();
		
		if (event.keyCode === 68) go.right();
		
		if (event.keyCode === 87) go.up();
		
		if (event.keyCode === 65) go.left();

		dibujar(enoja, canvas.width, canvas.height);

		return false;
	})
})()