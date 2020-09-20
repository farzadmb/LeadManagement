import React from 'react';

import Header from './Header';
import Summary from './Summary';
import './style.css';

const LeadDetails = (props) => {
    const { lead } = props;
    return (
        <div className='cart'>
            <div className='detail-items'>
                <Header lead={lead} />
            </div>
            <div className='separator'></div>
            <div className='detail-items'>
                <Summary lead={lead} />
            </div>
            <div className='separator'></div>
        </div>
    );
};

export default LeadDetails;