import React from 'react';

import Title from './Title';

const Header = (props) => {
    const { lead } = props;
    const { contact, time } = lead;

    return (
        <React.Fragment>
            <div>
                <Title contact={contact} time={time} />
            </div>
        </React.Fragment>
    );
};

export default Header;