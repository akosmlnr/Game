using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006B7 RID: 1719
	public class SettingsDropdown : MonoBehaviour
	{
		// Token: 0x06009854 RID: 38996 RVA: 0x00272E18 File Offset: 0x00271018
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsDropdown()
		{
			Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr);
			SettingsDropdown.NativeFieldInfoPtr_DefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "DefaultOptions");
			SettingsDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "dropdown");
			SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100682228);
			SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100682229);
			SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100682230);
			SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100682231);
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x00272EC0 File Offset: 0x002710C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 273253, RefRangeEnd = 273259, XrefRangeStart = 273240, XrefRangeEnd = 273253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x00272EFC File Offset: 0x002710FC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x00272F48 File Offset: 0x00271148
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 273270, RefRangeEnd = 273277, XrefRangeStart = 273259, XrefRangeEnd = 273270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x00272F8C File Offset: 0x0027118C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x00049B15 File Offset: 0x00047D15
		public SettingsDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600985A RID: 39002 RVA: 0x00272FC8 File Offset: 0x002711C8
		// (set) Token: 0x0600985B RID: 39003 RVA: 0x00049B1E File Offset: 0x00047D1E
		public unsafe Il2CppStringArray DefaultOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600985C RID: 39004 RVA: 0x00272FF8 File Offset: 0x002711F8
		// (set) Token: 0x0600985D RID: 39005 RVA: 0x00049B3D File Offset: 0x00047D3D
		public unsafe TMP_Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066BD RID: 26301
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptions;

		// Token: 0x040066BE RID: 26302
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x040066BF RID: 26303
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040066C0 RID: 26304
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040066C1 RID: 26305
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Protected_Void_String_0;

		// Token: 0x040066C2 RID: 26306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
