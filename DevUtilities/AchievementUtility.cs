using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046D RID: 1133
	public class AchievementUtility : MonoBehaviour
	{
		// Token: 0x0600619B RID: 24987 RVA: 0x001C1828 File Offset: 0x001BFA28
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementUtility()
		{
			Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AchievementUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr);
			AchievementUtility.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, "Achievement");
			AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100675844);
			AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100675845);
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x001C1894 File Offset: 0x001BFA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203205, XrefRangeEnd = 203211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x001C18C8 File Offset: 0x001BFAC8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x0002DD0C File Offset: 0x0002BF0C
		public AchievementUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600619F RID: 24991 RVA: 0x001C1904 File Offset: 0x001BFB04
		// (set) Token: 0x060061A0 RID: 24992 RVA: 0x0002DD15 File Offset: 0x0002BF15
		public unsafe AchievementManager.EAchievement Achievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement)) = value;
			}
		}

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeFieldInfoPtr_Achievement;

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_0;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
