using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000271 RID: 625
	[Serializable]
	public class AvatarAppearanceData : SaveData
	{
		// Token: 0x06002FD6 RID: 12246 RVA: 0x0010CB28 File Offset: 0x0010AD28
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAppearanceData()
		{
			Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AvatarAppearanceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr);
			AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr, "AvatarSettings");
			AvatarAppearanceData.NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr, 100668956);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0010CB80 File Offset: 0x0010AD80
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136199, XrefRangeEnd = 136201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAppearanceData(AvatarSettings avatarSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatarSettings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAppearanceData.NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0001900C File Offset: 0x0001720C
		public AvatarAppearanceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x0010CBCC File Offset: 0x0010ADCC
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x00019015 File Offset: 0x00017215
		public unsafe AvatarSettings AvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeFieldInfoPtr_AvatarSettings;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0;
	}
}
