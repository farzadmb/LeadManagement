import React from 'react';

const Price = (props) => {
    const { price } = props;
    
    return (
        <div>
            $ {price} Lead Invitation
        </div>
    )
};

export default Price