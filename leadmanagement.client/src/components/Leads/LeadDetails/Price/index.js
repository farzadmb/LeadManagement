import React from 'react';
import './style.css';

const Price = (props) => {
    const { price, bold } = props;
    
    return (
        <div>
            <span className={bold ? 'bold' : ''}>$ {price}</span> Lead Invitation
        </div>
    )
};

export default Price