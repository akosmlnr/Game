using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000683 RID: 1667
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x060093F2 RID: 37874 RVA: 0x002658F0 File Offset: 0x00263AF0
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressSlider()
		{
			Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ProgressSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr);
			ProgressSlider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Container");
			ProgressSlider.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Label");
			ProgressSlider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Slider");
			ProgressSlider.NativeFieldInfoPtr_SliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "SliderFill");
			ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "progressSetThisFrame");
			ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681733);
			ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681734);
			ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681735);
			ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681736);
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x002659D4 File Offset: 0x00263BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267341, XrefRangeEnd = 267343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x00265A08 File Offset: 0x00263C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267344, RefRangeEnd = 267345, XrefRangeStart = 267343, XrefRangeEnd = 267344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x00265A48 File Offset: 0x00263C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267345, RefRangeEnd = 267347, XrefRangeStart = 267345, XrefRangeEnd = 267345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(string label, Color sliderFillColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliderFillColor;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093F6 RID: 37878 RVA: 0x00265A98 File Offset: 0x00263C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267347, XrefRangeEnd = 267350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x00047464 File Offset: 0x00045664
		public ProgressSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x060093F8 RID: 37880 RVA: 0x00265AD4 File Offset: 0x00263CD4
		// (set) Token: 0x060093F9 RID: 37881 RVA: 0x0004746D File Offset: 0x0004566D
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x00265B04 File Offset: 0x00263D04
		// (set) Token: 0x060093FB RID: 37883 RVA: 0x0004748C File Offset: 0x0004568C
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x060093FC RID: 37884 RVA: 0x00265B34 File Offset: 0x00263D34
		// (set) Token: 0x060093FD RID: 37885 RVA: 0x000474AB File Offset: 0x000456AB
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x060093FE RID: 37886 RVA: 0x00265B64 File Offset: 0x00263D64
		// (set) Token: 0x060093FF RID: 37887 RVA: 0x000474CA File Offset: 0x000456CA
		public unsafe Image SliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x00265B94 File Offset: 0x00263D94
		// (set) Token: 0x06009401 RID: 37889 RVA: 0x000474E9 File Offset: 0x000456E9
		public unsafe bool progressSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame)) = value;
			}
		}

		// Token: 0x04006402 RID: 25602
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006403 RID: 25603
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006404 RID: 25604
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04006405 RID: 25605
		private static readonly IntPtr NativeFieldInfoPtr_SliderFill;

		// Token: 0x04006406 RID: 25606
		private static readonly IntPtr NativeFieldInfoPtr_progressSetThisFrame;

		// Token: 0x04006407 RID: 25607
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006408 RID: 25608
		private static readonly IntPtr NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0;

		// Token: 0x04006409 RID: 25609
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_String_Color_0;

		// Token: 0x0400640A RID: 25610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
