import React from 'react';

import Header from './Header';
import Summary from './Summary';

const LeadDetails = (props) => {
    const { lead } = props;
    return (
        <React.Fragment>
            <div>
                <Header lead={lead} />
            </div>
            <div>
                <Summary lead={lead} />
            </div>
        </React.Fragment>
    );
};

export default LeadDetails;