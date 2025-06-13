using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003E0 RID: 992
	public class RankData : SaveData
	{
		// Token: 0x06004C4C RID: 19532 RVA: 0x00172F74 File Offset: 0x00171174
		// Note: this type is marked as 'beforefieldinit'.
		static RankData()
		{
			Il2CppClassPointerStore<RankData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "RankData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankData>.NativeClassPtr);
			RankData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Rank");
			RankData.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Tier");
			RankData.NativeFieldInfoPtr_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "XP");
			RankData.NativeFieldInfoPtr_TotalXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "TotalXP");
			RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankData>.NativeClassPtr, 100672843);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00173008 File Offset: 0x00171208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169046, XrefRangeEnd = 169047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankData(int rank, int tier, int xp, int totalXP) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXP;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x000248D7 File Offset: 0x00022AD7
		public RankData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06004C4F RID: 19535 RVA: 0x0017307C File Offset: 0x0017127C
		// (set) Token: 0x06004C50 RID: 19536 RVA: 0x000248E0 File Offset: 0x00022AE0
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06004C51 RID: 19537 RVA: 0x001730A4 File Offset: 0x001712A4
		// (set) Token: 0x06004C52 RID: 19538 RVA: 0x000248FB File Offset: 0x00022AFB
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x001730CC File Offset: 0x001712CC
		// (set) Token: 0x06004C54 RID: 19540 RVA: 0x00024916 File Offset: 0x00022B16
		public unsafe int XP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP)) = value;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x001730F4 File Offset: 0x001712F4
		// (set) Token: 0x06004C56 RID: 19542 RVA: 0x00024931 File Offset: 0x00022B31
		public unsafe int TotalXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP)) = value;
			}
		}

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeFieldInfoPtr_XP;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeFieldInfoPtr_TotalXP;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
	}
}
