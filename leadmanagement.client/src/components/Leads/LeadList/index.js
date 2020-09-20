import React from 'react';
import LeadDetails from '../LeadDetails';

const LeadList = (props) => {
    const { leads } = props;

    const leadList = leads.map(l => <div key={l.id}><LeadDetails lead={l} /></div>);

    return (
        <div>
            {leadList}
        </div>
    );
};

export default LeadList;