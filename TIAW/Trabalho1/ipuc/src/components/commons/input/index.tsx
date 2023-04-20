import { InputHTMLAttributes } from "react";
import { formatReal } from "app/utils/money";

interface InputProps extends InputHTMLAttributes<HTMLInputElement> {
    onChange?: (value: any) => void;
    label: string;
    columnClasses?: string;
    currency?: boolean;
    error?: string;
}

export const Input: React.FC<InputProps> = ({
    id: string,
    onChange,
    label,
    columnClasses,
    id,
    error,
    currency,
    ... inputProps
}: InputProps ) => {

    const onInputChange = (event) => {
        let value = event.target.value;

        if(value && currency) {
            value = formatReal(value)
        }

        if(onChange) {
            onChange(value)
        }
    }

    return (
        <div className={`field column ${columnClasses}`}>
            <label className="label" htmlFor={id}>{label}</label>
            <div className="control">
                <input type="text" className="input" 
                                {...inputProps}
                                onChange={ onInputChange }
                                id={id}
                />
                {error &&
                    <p className="help is-danger">{ error }</p>
                }

            </div>
        </div>
    )
}