import React from 'react';

const Category = (props) => {
    const { category } = props;
    
    return (
        <div>
            -c- {category.name}
        </div>
    );
}

export default Category;