using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000641 RID: 1601
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x06008C88 RID: 35976 RVA: 0x0024FC94 File Offset: 0x0024DE94
		// Note: this type is marked as 'beforefieldinit'.
		static ACColorPickerReplicator()
		{
			Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACColorPickerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr);
			ACColorPickerReplicator.NativeFieldInfoPtr_picker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, "picker");
			ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100680868);
			ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100680869);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x0024FD00 File Offset: 0x0024DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258141, XrefRangeEnd = 258146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x0024FD50 File Offset: 0x0024DF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258150, RefRangeEnd = 258151, XrefRangeStart = 258146, XrefRangeEnd = 258150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACColorPickerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x00042EF7 File Offset: 0x000410F7
		public ACColorPickerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06008C8C RID: 35980 RVA: 0x0024FD8C File Offset: 0x0024DF8C
		// (set) Token: 0x06008C8D RID: 35981 RVA: 0x00042F00 File Offset: 0x00041100
		public unsafe ColorPicker picker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F67 RID: 24423
		private static readonly IntPtr NativeFieldInfoPtr_picker;

		// Token: 0x04005F68 RID: 24424
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005F69 RID: 24425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
