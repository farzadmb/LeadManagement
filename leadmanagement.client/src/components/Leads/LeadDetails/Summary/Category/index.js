import React from 'react';

import Icon from '../../../../Helpers/Icon';

const Category = (props) => {
    const { category } = props;
    
    return (
        <div>
            <Icon name='briefcase'/> {category.name}
        </div>
    );
}

export default Category;