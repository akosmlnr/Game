using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006AA RID: 1706
	public class CameraBobSlider : SettingsSlider
	{
		// Token: 0x060097EB RID: 38891 RVA: 0x00271744 File Offset: 0x0026F944
		// Note: this type is marked as 'beforefieldinit'.
		static CameraBobSlider()
		{
			Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "CameraBobSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr);
			CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100682167);
			CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100682168);
			CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100682169);
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x002717B0 File Offset: 0x0026F9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272735, XrefRangeEnd = 272740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x002717EC File Offset: 0x0026F9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272740, XrefRangeEnd = 272750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x00271838 File Offset: 0x0026FA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272750, XrefRangeEnd = 272751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraBobSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x0004998D File Offset: 0x00047B8D
		public CameraBobSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400667A RID: 26234
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400667B RID: 26235
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x0400667C RID: 26236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
