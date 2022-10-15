const AnotherComponent = () => {

const handleClick = () =>{
    console.log("Clickou no Botão!");
};

 return (
    <div>
        <p>Segundo Componente</p>
        <button onClick={handleClick}>Evento de click</button>
        <hr/>
        <button onClick={() => console.log("Teste")}>Evento no Elemento</button>
        
    </div>
 );
};

export default AnotherComponent;