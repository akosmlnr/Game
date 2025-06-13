using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A1 RID: 673
	[Serializable]
	public class MoneyData : SaveData
	{
		// Token: 0x0600313B RID: 12603 RVA: 0x00110A1C File Offset: 0x0010EC1C
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyData()
		{
			Il2CppClassPointerStore<MoneyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoneyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyData>.NativeClassPtr);
			MoneyData.NativeFieldInfoPtr_OnlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "OnlineBalance");
			MoneyData.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "Networth");
			MoneyData.NativeFieldInfoPtr_LifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "LifetimeEarnings");
			MoneyData.NativeFieldInfoPtr_WeeklyDepositSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "WeeklyDepositSum");
			MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, 100669038);
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00110AB0 File Offset: 0x0010ECB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136832, RefRangeEnd = 136833, XrefRangeStart = 136831, XrefRangeEnd = 136832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlineBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimeEarnings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weeklyDepositSum;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00019DB0 File Offset: 0x00017FB0
		public MoneyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x00110B24 File Offset: 0x0010ED24
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x00019DB9 File Offset: 0x00017FB9
		public unsafe float OnlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance)) = value;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x00110B4C File Offset: 0x0010ED4C
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x00019DD4 File Offset: 0x00017FD4
		public unsafe float Networth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x00110B74 File Offset: 0x0010ED74
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x00019DEF File Offset: 0x00017FEF
		public unsafe float LifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings)) = value;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x00110B9C File Offset: 0x0010ED9C
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x00019E0A File Offset: 0x0001800A
		public unsafe float WeeklyDepositSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum)) = value;
			}
		}

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalance;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarnings;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositSum;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
	}
}
