import functools
import time

def timer_decorator(func):
    @functools.wraps(func)
    def wrapper_timer(*args, **kwargs):
        start_time = time.perf_counter()
        value = func(*args, **kwargs)
        end_time = time.perf_counter()
        run_time = end_time - start_time
        print(f"Finished {func.__name__}() in {run_time:.4f} secs")
        return value
    return wrapper_timer



@timer_decorator
def waste_some_time(num_times):
    for _ in range(num_times):
        time.sleep(1)


waste_some_time(1)