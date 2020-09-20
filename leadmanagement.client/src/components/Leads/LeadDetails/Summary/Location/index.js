import React from 'react';

import Icon from '../../../../Helpers/Icon';

const Location = (props) => {
    const { suburb } = props;
    
    return (
        <div>
            <Icon name='location'/> {suburb.name} {suburb.postCode}
        </div>
    );
};

export default Location;