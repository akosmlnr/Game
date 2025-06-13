using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000643 RID: 1603
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x06008C91 RID: 35985 RVA: 0x0024FDF8 File Offset: 0x0024DFF8
		// Note: this type is marked as 'beforefieldinit'.
		static ACReplicator()
		{
			Il2CppClassPointerStore<ACReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr);
			ACReplicator.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, "propertyName");
			ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680871);
			ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680872);
			ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680873);
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x0024FE78 File Offset: 0x0024E078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258154, XrefRangeEnd = 258179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x0024FEAC File Offset: 0x0024E0AC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x0024FEFC File Offset: 0x0024E0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258150, RefRangeEnd = 258151, XrefRangeStart = 258150, XrefRangeEnd = 258151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x00042F61 File Offset: 0x00041161
		public ACReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06008C96 RID: 35990 RVA: 0x0024FF38 File Offset: 0x0024E138
		// (set) Token: 0x06008C97 RID: 35991 RVA: 0x00042F6A File Offset: 0x0004116A
		public unsafe string propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005F6B RID: 24427
		private static readonly IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04005F6C RID: 24428
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005F6D RID: 24429
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0;

		// Token: 0x04005F6E RID: 24430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
