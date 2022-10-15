import AnotherComponent from "./AnotherComponent";

function FirstComponent(){
    // Comentário estilo JS

    const name = "Felipe";

   return (
     <div className="firstComponent">
        {/*Modelo de comentário no JSX*/}
        <p>Primeiro Componente</p>
        {2 + 2}
        {console.log("JAVASCRIPT")}
        <p>Nome: {name}</p>
        <AnotherComponent />
     </div>
   )

}

export default FirstComponent