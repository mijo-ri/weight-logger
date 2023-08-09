import { TextField as MuiTextField } from '@mui/material';
import { useController } from 'react-hook-form';

const TextField = ({ control, name, ...otherProps }) => {
  const {
    field,
    fieldState: { error },
  } = useController({
    name,
    control,
  });

  const config = {
    ...field,
    error: !!error,
    helperText: error?.message,
    fullWidth: true,
    variant: 'outlined',
    ...otherProps,
  };

  return <MuiTextField {...config} />;
};

export default TextField;
