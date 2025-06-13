using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006AB RID: 1707
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		// Token: 0x060097F0 RID: 38896 RVA: 0x00271874 File Offset: 0x0026FA74
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmDisplaySettings()
		{
			Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "ConfirmDisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr);
			ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "RevertTime");
			ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "SubtitleLabel");
			ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "timeUntilRevert");
			ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "oldSettings");
			ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "newSettings");
			ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682170);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682171);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682172);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682173);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682174);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682175);
			ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100682176);
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x060097F1 RID: 38897 RVA: 0x00271994 File Offset: 0x0026FB94
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272751, XrefRangeEnd = 272761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x002719D0 File Offset: 0x0026FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272761, XrefRangeEnd = 272774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x00271A04 File Offset: 0x0026FC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272784, RefRangeEnd = 272785, XrefRangeStart = 272774, XrefRangeEnd = 272784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _oldSettings;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _newSettings;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x00271A50 File Offset: 0x0026FC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272785, XrefRangeEnd = 272797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x00271A94 File Offset: 0x0026FC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272797, XrefRangeEnd = 272805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x00271AC8 File Offset: 0x0026FCC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272831, RefRangeEnd = 272834, XrefRangeStart = 272805, XrefRangeEnd = 272831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool revert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref revert;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x00271B08 File Offset: 0x0026FD08
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmDisplaySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x00049996 File Offset: 0x00047B96
		public ConfirmDisplaySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x060097F9 RID: 38905 RVA: 0x00271B44 File Offset: 0x0026FD44
		// (set) Token: 0x060097FA RID: 38906 RVA: 0x0004999F File Offset: 0x00047B9F
		public unsafe static float RevertTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&value));
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x060097FB RID: 38907 RVA: 0x00271B60 File Offset: 0x0026FD60
		// (set) Token: 0x060097FC RID: 38908 RVA: 0x000499AD File Offset: 0x00047BAD
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x060097FD RID: 38909 RVA: 0x00271B90 File Offset: 0x0026FD90
		// (set) Token: 0x060097FE RID: 38910 RVA: 0x000499CC File Offset: 0x00047BCC
		public unsafe float timeUntilRevert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert)) = value;
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x060097FF RID: 38911 RVA: 0x00271BB8 File Offset: 0x0026FDB8
		// (set) Token: 0x06009800 RID: 38912 RVA: 0x000499E7 File Offset: 0x00047BE7
		public unsafe DisplaySettings oldSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings)) = value;
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x06009801 RID: 38913 RVA: 0x00271BE0 File Offset: 0x0026FDE0
		// (set) Token: 0x06009802 RID: 38914 RVA: 0x00049A02 File Offset: 0x00047C02
		public unsafe DisplaySettings newSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings)) = value;
			}
		}

		// Token: 0x0400667D RID: 26237
		private static readonly IntPtr NativeFieldInfoPtr_RevertTime;

		// Token: 0x0400667E RID: 26238
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x0400667F RID: 26239
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilRevert;

		// Token: 0x04006680 RID: 26240
		private static readonly IntPtr NativeFieldInfoPtr_oldSettings;

		// Token: 0x04006681 RID: 26241
		private static readonly IntPtr NativeFieldInfoPtr_newSettings;

		// Token: 0x04006682 RID: 26242
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006683 RID: 26243
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006684 RID: 26244
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0;

		// Token: 0x04006685 RID: 26245
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006686 RID: 26246
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006687 RID: 26247
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006688 RID: 26248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
