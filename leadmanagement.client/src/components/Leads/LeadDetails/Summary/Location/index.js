import React from 'react';

const Location = (props) => {
    const { suburb } = props;
    
    return (
        <div>
            -l- {suburb.name} {suburb.postCode}
        </div>
    );
};

export default Location;