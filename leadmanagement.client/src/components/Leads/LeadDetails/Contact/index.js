import React from 'react';

import Icon from '../../../Helpers/Icon';
import './style.css';

const Contact = (props) => {
    const { contact } = props;
    const { phone, email } = contact;

    return (
        <div className='contact-list'>
            <div>
                <Icon name='phone' />
                <span className='contact-detail'>{phone}</span>
            </div>
            <div>
                <Icon name='email' />
                <span className='contact-detail'>{email}</span>
            </div>
        </div>
    );
};

export default Contact;