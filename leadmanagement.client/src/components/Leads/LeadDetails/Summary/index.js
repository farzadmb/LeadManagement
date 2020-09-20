import React from 'react';

import Location from './Location';
import Category from './Category';
import JobId from './JobId';
import Price from './Price';
import './style.css';

const Summary = (props) => {    
    const { lead } = props;
    const { id, suburb, category, price } = lead;
    
    return (
        <div className='summary-list'>
            <div className='summary-item'>
                <Location suburb={suburb} />
            </div>
            <div className='summary-item'>
                <Category category={category} />
            </div>
            <div className='summary-item'>
                <JobId id={id} />
            </div>
            <div className='summary-item'>
                <Price price={price} />
            </div>
        </div>
    );
};

export default Summary;