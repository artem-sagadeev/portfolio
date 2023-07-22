import './Case.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useState, useEffect } from 'react';

const Case = (props) => {
    const { item } = props;
    const [image, setData] = useState(null);

    const url = `http://localhost:5029/api/images/${item.previewImageId}`;
    console.log(url);

    useEffect(() => {
        fetch(url)
            .then((response) => 
                response.blob())
            .then((imageBlob) => {
                const imageUrl = URL.createObjectURL(imageBlob);
                console.log(imageUrl);

                setData(imageUrl);
            });
    }, []);

    return (
        <div className='col-6'>
            <div className='row p-4'>
                <div className='px-4'>
                    {image && <img className='case-preview-image' src={image} />}
                </div>
                
                <div className='px-5 py-3 fs-3 text-center'>
                    {item.title}
                </div>
                <div className='px-5 py-1 fs-4 text-center'>
                    {item.shortDescription}
                </div>
            </div>
        </div>
    );
}

export default Case;
