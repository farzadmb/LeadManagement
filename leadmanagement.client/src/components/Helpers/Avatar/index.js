import React from 'react';

import './style.css';

const DateFormatter = (props) => {
    const { content } = props;

    return (
        <div className='numberCircle'>
            {content}
        </div>
    );
};

export default DateFormatter;