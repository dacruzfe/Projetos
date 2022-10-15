const RenderCond = ({ x, y }) => {
     //const x = 6;

    return <div>
        {x > 5 && <p>x é maior que 5</p>}
         {/*If Ternário*/}
         {x > 5 ? <p>x é um número alto</p> : <p>x é um número baixo</p>}
         <p>O valor de y é: {y}</p>
        </div>
};

export default RenderCond;