import React from 'react';

const intl = new Intl.DateTimeFormat("en-US", {
    year: "numeric",
    month: "long",
    day: "2-digit"
});

const DateFormatter = (props) => {
    const { time } = props;
    
    return (
        <div>
            {intl.format(new Date(time))}
        </div>
    );
};

export default DateFormatter;