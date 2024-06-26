(function() {
    window.onload = function() {
        //Personajes
        let personajes = [
            {id: "p1", nombre: "Colt", tipo: "francotirador", salud: 2800, ataque: 300, imagen: "img/colt.png", habilidad: "Se puede mover muy rápido"},
            {id: "p2", nombre: "Jessie", tipo: "luchador", salud: 3200, ataque: 820, imagen: "img/jessie.png", habilidad: "Restaura la salud de su torreta"},
            {id: "p3", nombre: "Brock", tipo: "francotirador", salud: 2800, ataque: 1100, imagen: "img/brock.png", habilidad: "Lanza una potente salva de 9 misiles"},
            {id: "p4", nombre: "Rico", tipo: "francotirador", salud: 2600, ataque: 280, imagen: "img/rico.png", habilidad: "Sus balas son más rápidas y dañinas al chocar contra algo"},
            {id: "p5", nombre: "Shelly", tipo: "luchador", salud: 3600, ataque: 300, imagen: "img/shelly.png", habilidad: "Ralentiza a los enemigos de un área con su ataque"},
            {id: "p6", nombre: "Nita", tipo: "luchador", salud: 3800, ataque: 740, imagen: "img/nita.png", habilidad: "Recupera salud con sus ataques"}
        ];

        //Cargar personajes
        function cargar(personajes) {
            personajes.sort((a, b) => a.nombre.localeCompare(b.nombre));

            let personajesSec = document.getElementById("personajes");
            personajesSec.innerHTML = "";

            personajes.forEach(personaje => {
                let list = document.createElement("section");
                list.classList.add("listado");

                list.innerHTML = `
                    <section>
                        <img src="${personaje.imagen}" id="${personaje.id}" draggable="true">
                    </section>
                    <section>
                        <h2>${personaje.nombre}</h2>
                    </section>
                `;
                personajesSec.appendChild(list);

                eventoArrastre();
            });
        }

        //Filtrado y uso de botones
        function filtrar(tipo) {
            let persFiltrado = personajes.filter(personaje => personaje.tipo == tipo);
            cargar(persFiltrado);
        }

        let luchador = document.getElementById("luchador");
        luchador.addEventListener("click", function() {
            filtrar("luchador");
        });

        let francotirador = document.getElementById("francotirador");
        francotirador.addEventListener("click", function() {
            filtrar("francotirador");
        });

        let todos = document.getElementById("todos");
        todos.addEventListener("click", function() {
            cargar(personajes);
        });

        //Uso de eventos de arrastre
        function eventoArrastre() {
            let imagenes = document.querySelectorAll("#personajes img");

            imagenes.forEach(imagen => {
                imagen.addEventListener("dragstart", function(event) {
                    event.dataTransfer.setData("text/plain", event.target.id);
                });
            });

            let lupa = document.getElementById("lupa");

            lupa.addEventListener("dragover", function(event) {
                event.preventDefault();
            });

            lupa.addEventListener("drop", function(event) {
                event.preventDefault();
                let idPersonaje = event.dataTransfer.getData("text/plain");
                mostrarFicha(idPersonaje);
            });
        }

        let ficha = document.getElementById("ficha");
        function mostrarFicha(idPersonaje) {
            let personaje = personajes.find(p => p.id == idPersonaje);
        
            if (personaje) {
                ficha.style.width = "400px";
                ficha.style.height = "620px";
                ficha.innerHTML = `
                    <h2>Ficha de personaje</h2>
                    <section id="detalle">
                        <img style ="width: 400px;" src="${personaje.imagen}">
                        <section>
                            <p><strong>Nombre: </strong>${personaje.nombre}</p>
                            <p><strong>Tipo: </strong>${personaje.tipo}</p>
                            <p><strong>Salud: </strong>${personaje.salud}</p>
                            <p><strong>Ataque: </strong>${personaje.ataque}</p>
                            <p><strong>Habilidad: </strong>${personaje.habilidad}</p>
                        </section>
                    </section>
                `;
            }
        }

        function eventoMouse(){
            ficha.addEventListener("mouseenter", function() {
                this.style.backgroundColor = "#2275c2";
            });
    
            ficha.addEventListener("mouseleave", function() {
                this.style.backgroundColor = "#045FB4";
            });
        }

        cargar(personajes);
        eventoMouse();
    };
})();
