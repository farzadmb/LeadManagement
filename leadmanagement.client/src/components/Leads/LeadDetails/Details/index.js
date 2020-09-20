import React from 'react';

import Contact from '../Contact';
import './style.css';

const Details = (props) => {
    const { lead } = props;
    const { contact, description, status } = lead;

    let contactDetails = (<div><Contact contact={contact} /></div>);

    if (status === 0)
    {
        contactDetails = null;
    }

    return (
        <div>
            {contactDetails}
            <div className='description'>
                {description}
            </div>
        </div>
    )
};

export default Details;