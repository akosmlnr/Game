using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne
{
	// Token: 0x02000176 RID: 374
	public class AchievementManager : PersistentSingleton<AchievementManager>
	{
		// Token: 0x06001DDE RID: 7646 RVA: 0x000D054C File Offset: 0x000CE74C
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementManager()
		{
			Il2CppClassPointerStore<AchievementManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "AchievementManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr);
			AchievementManager.NativeFieldInfoPtr_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievements");
			AchievementManager.NativeFieldInfoPtr_achievementUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievementUnlocked");
			AchievementManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666732);
			AchievementManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666733);
			AchievementManager.NativeMethodInfoPtr_PullAchievements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666734);
			AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666735);
			AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666736);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000D0608 File Offset: 0x000CE808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109524, XrefRangeEnd = 109562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000D0644 File Offset: 0x000CE844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109562, XrefRangeEnd = 109597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000D0680 File Offset: 0x000CE880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109597, XrefRangeEnd = 109615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PullAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_PullAchievements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000D06B4 File Offset: 0x000CE8B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 109640, RefRangeEnd = 109649, XrefRangeStart = 109615, XrefRangeEnd = 109640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievement;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000D06F4 File Offset: 0x000CE8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109649, XrefRangeEnd = 109659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00010C44 File Offset: 0x0000EE44
		public AchievementManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000D0730 File Offset: 0x000CE930
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x00010C4D File Offset: 0x0000EE4D
		public unsafe Il2CppStructArray<AchievementManager.EAchievement> achievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AchievementManager.EAchievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000D0760 File Offset: 0x000CE960
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00010C6C File Offset: 0x0000EE6C
		public unsafe Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AchievementManager.EAchievement, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr_achievements;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_achievementUnlocked;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_PullAchievements_Private_Void_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008D7 RID: 2263
		[OriginalName("Assembly-CSharp.dll", "", "EAchievement")]
		public enum EAchievement
		{
			// Token: 0x04008715 RID: 34581
			COMPLETE_PROLOGUE,
			// Token: 0x04008716 RID: 34582
			RV_DESTROYED,
			// Token: 0x04008717 RID: 34583
			DEALER_RECRUITED,
			// Token: 0x04008718 RID: 34584
			MASTER_CHEF,
			// Token: 0x04008719 RID: 34585
			BUSINESSMAN,
			// Token: 0x0400871A RID: 34586
			BIGWIG,
			// Token: 0x0400871B RID: 34587
			MAGNATE,
			// Token: 0x0400871C RID: 34588
			UPSTANDING_CITIZEN,
			// Token: 0x0400871D RID: 34589
			ROLLING_IN_STYLE,
			// Token: 0x0400871E RID: 34590
			LONG_ARM_OF_THE_LAW,
			// Token: 0x0400871F RID: 34591
			INDIAN_DEALER
		}
	}
}
