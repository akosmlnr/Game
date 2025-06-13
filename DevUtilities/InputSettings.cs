using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000496 RID: 1174
	[System.Serializable]
	public class InputSettings : Il2CppSystem.Object
	{
		// Token: 0x0600645F RID: 25695 RVA: 0x001CA050 File Offset: 0x001C8250
		// Note: this type is marked as 'beforefieldinit'.
		static InputSettings()
		{
			Il2CppClassPointerStore<InputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "InputSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSettings>.NativeClassPtr);
			InputSettings.NativeFieldInfoPtr_MouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "MouseSensitivity");
			InputSettings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "InvertMouse");
			InputSettings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "SprintMode");
			InputSettings.NativeFieldInfoPtr_BindingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "BindingOverrides");
			InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, 100676116);
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x001CA0E4 File Offset: 0x001C82E4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x0002F37F File Offset: 0x0002D57F
		public InputSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06006462 RID: 25698 RVA: 0x001CA120 File Offset: 0x001C8320
		// (set) Token: 0x06006463 RID: 25699 RVA: 0x0002F388 File Offset: 0x0002D588
		public unsafe float MouseSensitivity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity)) = value;
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06006464 RID: 25700 RVA: 0x001CA148 File Offset: 0x001C8348
		// (set) Token: 0x06006465 RID: 25701 RVA: 0x0002F3A3 File Offset: 0x0002D5A3
		public unsafe bool InvertMouse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06006466 RID: 25702 RVA: 0x001CA170 File Offset: 0x001C8370
		// (set) Token: 0x06006467 RID: 25703 RVA: 0x0002F3BE File Offset: 0x0002D5BE
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x001CA198 File Offset: 0x001C8398
		// (set) Token: 0x06006469 RID: 25705 RVA: 0x0002F3D9 File Offset: 0x0002D5D9
		public unsafe string BindingOverrides
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004477 RID: 17527
		private static readonly System.IntPtr NativeFieldInfoPtr_MouseSensitivity;

		// Token: 0x04004478 RID: 17528
		private static readonly System.IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x04004479 RID: 17529
		private static readonly System.IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x0400447A RID: 17530
		private static readonly System.IntPtr NativeFieldInfoPtr_BindingOverrides;

		// Token: 0x0400447B RID: 17531
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6C RID: 2668
		[OriginalName("Assembly-CSharp.dll", "", "EActionMode")]
		public enum EActionMode
		{
			// Token: 0x04008F3C RID: 36668
			Press,
			// Token: 0x04008F3D RID: 36669
			Hold
		}
	}
}
