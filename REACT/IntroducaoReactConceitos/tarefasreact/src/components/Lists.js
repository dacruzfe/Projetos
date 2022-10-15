const List = () => {
    const items = [{
        id: 1,
        name: "Felipe",
    },
    {
        id: 2,
        name: "Bernardo",
    },
    {
        id: 3,
        name: "Ryan",
    },
];

    return (<div>
        {items.map((item) => (
            <p key={item.id}>
                {item.id} - {item.name}
            </p>
        ))}
    </div>);
};

export default List;