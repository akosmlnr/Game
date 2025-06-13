using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000644 RID: 1604
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x06008C98 RID: 35992 RVA: 0x0024FF60 File Offset: 0x0024E160
		// Note: this type is marked as 'beforefieldinit'.
		static ACSliderReplicator()
		{
			Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSliderReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr);
			ACSliderReplicator.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, "slider");
			ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100680874);
			ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100680875);
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x0024FFCC File Offset: 0x0024E1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258179, XrefRangeEnd = 258185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C9A RID: 35994 RVA: 0x0025001C File Offset: 0x0024E21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258150, RefRangeEnd = 258151, XrefRangeStart = 258150, XrefRangeEnd = 258151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSliderReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x00042F89 File Offset: 0x00041189
		public ACSliderReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00250058 File Offset: 0x0024E258
		// (set) Token: 0x06008C9D RID: 35997 RVA: 0x00042F92 File Offset: 0x00041192
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F6F RID: 24431
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04005F70 RID: 24432
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005F71 RID: 24433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
