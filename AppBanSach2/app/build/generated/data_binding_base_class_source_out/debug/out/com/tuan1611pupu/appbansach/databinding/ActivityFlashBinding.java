// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.viewbinding.ViewBinding;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;

public final class ActivityFlashBinding implements ViewBinding {
  @NonNull
  private final LinearLayoutCompat rootView;

  private ActivityFlashBinding(@NonNull LinearLayoutCompat rootView) {
    this.rootView = rootView;
  }

  @Override
  @NonNull
  public LinearLayoutCompat getRoot() {
    return rootView;
  }

  @NonNull
  public static ActivityFlashBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static ActivityFlashBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.activity_flash, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static ActivityFlashBinding bind(@NonNull View rootView) {
    if (rootView == null) {
      throw new NullPointerException("rootView");
    }

    return new ActivityFlashBinding((LinearLayoutCompat) rootView);
  }
}
