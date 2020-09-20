import React from 'react';
import LeadDetails from '../LeadDetails';

const LeadList = (props) => {
    const { leads } = props;

    return (
        <div>
            <LeadDetails lead={leads[0]} />
        </div>
    );
};

export default LeadList;