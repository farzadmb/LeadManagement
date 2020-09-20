import React from 'react';

import DateFormatter from '../../../Helpers/DateFormatter';
import Avatar from '../../../Helpers/Avatar';
import './style.css';

const Header = (props) => {
    const { lead } = props;
    const { contact, time } = lead;

    const { name } = contact;

    return (
        <div className='collection-item'>
            <div>
                <Avatar content={name.charAt(0)} />
            </div>
            <div>
                <div className='contact-name'>
                    {name.split(" ")[0]}
                </div>
                <div className='lead-time'>
                    <DateFormatter time={time} />
                </div>
            </div>
        </div>
    );
};

export default Header;