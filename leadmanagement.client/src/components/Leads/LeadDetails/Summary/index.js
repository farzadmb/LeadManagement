import React from 'react';

import Location from './Location';
import Category from './Category';
import JobId from './JobId';
import Price from './Price';

const Summary = (props) => {    
    const { lead } = props;
    const { id, suburb, category, price } = lead;
    
    return (
        <React.Fragment>
            <div>
                <Location suburb={suburb} />
            </div>
            <div>
                <Category category={category} />
            </div>
            <div>
                <JobId id={id} />
            </div>
            <div>
                <Price price={price} />
            </div>
        </React.Fragment>
    );
};

export default Summary;