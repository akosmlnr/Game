using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000752 RID: 1874
	public class Transaction : Il2CppSystem.Object
	{
		// Token: 0x0600A8A0 RID: 43168 RVA: 0x002A5228 File Offset: 0x002A3428
		// Note: this type is marked as 'beforefieldinit'.
		static Transaction()
		{
			Il2CppClassPointerStore<Transaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "Transaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transaction>.NativeClassPtr);
			Transaction.NativeFieldInfoPtr_transaction_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Name");
			Transaction.NativeFieldInfoPtr_unit_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "unit_Amount");
			Transaction.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "quantity");
			Transaction.NativeFieldInfoPtr_transaction_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Note");
			Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100684026);
			Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100684027);
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002A52D0 File Offset: 0x002A34D0
		public unsafe float total_Amount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x002A530C File Offset: 0x002A350C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294428, XrefRangeEnd = 294436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transaction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x00052DE7 File Offset: 0x00050FE7
		public Transaction(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600A8A4 RID: 43172 RVA: 0x002A5388 File Offset: 0x002A3588
		// (set) Token: 0x0600A8A5 RID: 43173 RVA: 0x00052DF0 File Offset: 0x00050FF0
		public unsafe string transaction_Name
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x002A53B0 File Offset: 0x002A35B0
		// (set) Token: 0x0600A8A7 RID: 43175 RVA: 0x00052E0F File Offset: 0x0005100F
		public unsafe float unit_Amount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount)) = value;
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x002A53D8 File Offset: 0x002A35D8
		// (set) Token: 0x0600A8A9 RID: 43177 RVA: 0x00052E2A File Offset: 0x0005102A
		public unsafe float quantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600A8AA RID: 43178 RVA: 0x002A5400 File Offset: 0x002A3600
		// (set) Token: 0x0600A8AB RID: 43179 RVA: 0x00052E45 File Offset: 0x00051045
		public unsafe string transaction_Note
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04007118 RID: 28952
		private static readonly System.IntPtr NativeFieldInfoPtr_transaction_Name;

		// Token: 0x04007119 RID: 28953
		private static readonly System.IntPtr NativeFieldInfoPtr_unit_Amount;

		// Token: 0x0400711A RID: 28954
		private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x0400711B RID: 28955
		private static readonly System.IntPtr NativeFieldInfoPtr_transaction_Note;

		// Token: 0x0400711C RID: 28956
		private static readonly System.IntPtr NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0;

		// Token: 0x0400711D RID: 28957
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0;
	}
}
