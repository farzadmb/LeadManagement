import React from 'react';

import Header from './Header';
import Summary from './Summary';
import Details from './Details';
import Action from './Actions';
import './style.css';

const LeadDetails = (props) => {
    const { lead } = props;

    return (
        <div className='cart'>
            <div className='detail-items'>
                <Header lead={lead} />
            </div>
            <div className='separator' />
            <div className='detail-items'>
                <Summary lead={lead} />
            </div>
            <div className='separator' />
            <div className='detail-items'>
                <Details lead={lead} />
            </div>
            <div className='separator' />
            <div className='summary-item'>
                <Action lead={lead} />
            </div>
        </div>
    );
};

export default LeadDetails;