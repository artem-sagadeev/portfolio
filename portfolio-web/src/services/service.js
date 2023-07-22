const fetchData = async () => {
    try {
        const response = await fetch('http://localhost:5029/api/cases/previews'); 
        const jsonData = await response.json();
        cobnsole.log(jsonData);
    } catch (error) {
        console.log(error);
    }
};