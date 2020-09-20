import React from 'react';

const LeadList = (props) => {
    const { leads } = props;

    return (
        <div>
            Leads list. Count = {leads.length}
        </div>
    );
};

export default LeadList;