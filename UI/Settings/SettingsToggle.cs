using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006B9 RID: 1721
	public class SettingsToggle : MonoBehaviour
	{
		// Token: 0x0600986F RID: 39023 RVA: 0x0027333C File Offset: 0x0027153C
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsToggle()
		{
			Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr);
			SettingsToggle.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, "toggle");
			SettingsToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100682237);
			SettingsToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100682238);
			SettingsToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100682239);
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x002733BC File Offset: 0x002715BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273307, XrefRangeEnd = 273319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x002733F8 File Offset: 0x002715F8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x00273444 File Offset: 0x00271644
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x00049BE7 File Offset: 0x00047DE7
		public SettingsToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x06009874 RID: 39028 RVA: 0x00273480 File Offset: 0x00271680
		// (set) Token: 0x06009875 RID: 39029 RVA: 0x00049BF0 File Offset: 0x00047DF0
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsToggle.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsToggle.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066CD RID: 26317
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040066CE RID: 26318
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040066CF RID: 26319
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040066D0 RID: 26320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
