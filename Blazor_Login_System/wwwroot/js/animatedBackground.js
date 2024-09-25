document.addEventListener("DOMContentLoaded", function () {
    let canvas = document.getElementById("myCanvas")
    let ctx = canvas.getContext("2d");

    // Set canvas dimensions to full window
    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;


    // Handle resize event
    window.addEventListener('resize', function () {
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
    });

    let stars = [];
    let numStars = 10000;

    // Create random stars
    function createStars() {
        for (let i = 0; i < numStars; i++) {
            stars.push({
                x: Math.random() * canvas.width,
                y: Math.random() * canvas.height,
                size: Math.random() * 3,
                speed: Math.random() * 2 + 0.5,
            });
        }
    }

    function updateStars() {
        for (let i = 0; i < stars.length; i++) {
            stars[i].y += stars[i].speed;

            // Reset position when stars move off screen
            if (stars[i].y > canvas.height) {
                stars[i].y = 0;
                stars[i].x = Math.random() * canvas.width;
            }
        }
    }

    function drawStars() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);

        for (let i = 0; i < stars.length; i++) {
            ctx.beginPath();
            ctx.arc(stars[i].x, stars[i].y, stars[i].size, 0, Math.PI * 2);
            ctx.fillStyle = "red";
            ctx.fill();
        }
    }

    function animate() {
        updateStars();
        drawStars();
        requestAnimationFrame(animate);
    }

    createStars();
    animate();
});
