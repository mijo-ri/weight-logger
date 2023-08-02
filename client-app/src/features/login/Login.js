import { useForm } from 'react-hook-form';
import { useAuth } from '../../auth/AuthContext';

const Login = () => {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

  const { login, isAuthenticated } = useAuth();

  const onSubmit = (data) => {
    console.log('data', data);

    login(data.email, data.password);
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <div>
        <input
          type='text'
          placeholder='Email'
          {...register('email', { required: true })}
        />
      </div>
      <div>
        <input
          type='password'
          placeholder='Password'
          {...register('password', { required: true })}
        />
      </div>
      <div>
        <input type='submit' value='Login' />
      </div>
    </form>
  );
};

export default Login;
