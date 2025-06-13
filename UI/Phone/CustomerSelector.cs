using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C0 RID: 1728
	public class CustomerSelector : MonoBehaviour
	{
		// Token: 0x060098FB RID: 39163 RVA: 0x00274D2C File Offset: 0x00272F2C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSelector()
		{
			Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CustomerSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr);
			CustomerSelector.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "ButtonPrefab");
			CustomerSelector.NativeFieldInfoPtr_EntriesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "EntriesContainer");
			CustomerSelector.NativeFieldInfoPtr_onCustomerSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "onCustomerSelected");
			CustomerSelector.NativeFieldInfoPtr_customerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "customerEntries");
			CustomerSelector.NativeFieldInfoPtr_entryToCustomer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "entryToCustomer");
			CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682303);
			CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682304);
			CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682305);
			CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682306);
			CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682307);
			CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682308);
			CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682309);
			CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682310);
			CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100682311);
		}

		// Token: 0x060098FC RID: 39164 RVA: 0x00274E74 File Offset: 0x00273074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274126, XrefRangeEnd = 274161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x00274EA8 File Offset: 0x002730A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274161, XrefRangeEnd = 274171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x00274EDC File Offset: 0x002730DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274171, XrefRangeEnd = 274193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x00274F10 File Offset: 0x00273110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274193, XrefRangeEnd = 274206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00274F54 File Offset: 0x00273154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274228, RefRangeEnd = 274229, XrefRangeStart = 274206, XrefRangeEnd = 274228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x00274F88 File Offset: 0x00273188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199161, RefRangeEnd = 199164, XrefRangeStart = 199161, XrefRangeEnd = 199164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x00274FBC File Offset: 0x002731BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274278, RefRangeEnd = 274279, XrefRangeStart = 274229, XrefRangeEnd = 274278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x00275000 File Offset: 0x00273200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274279, XrefRangeEnd = 274289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerSelected(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x00275044 File Offset: 0x00273244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274289, XrefRangeEnd = 274304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x0004A080 File Offset: 0x00048280
		public CustomerSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x06009906 RID: 39174 RVA: 0x00275080 File Offset: 0x00273280
		// (set) Token: 0x06009907 RID: 39175 RVA: 0x0004A089 File Offset: 0x00048289
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x06009908 RID: 39176 RVA: 0x002750B0 File Offset: 0x002732B0
		// (set) Token: 0x06009909 RID: 39177 RVA: 0x0004A0A8 File Offset: 0x000482A8
		public unsafe RectTransform EntriesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600990A RID: 39178 RVA: 0x002750E0 File Offset: 0x002732E0
		// (set) Token: 0x0600990B RID: 39179 RVA: 0x0004A0C7 File Offset: 0x000482C7
		public unsafe UnityEvent<Customer> onCustomerSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Customer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600990C RID: 39180 RVA: 0x00275110 File Offset: 0x00273310
		// (set) Token: 0x0600990D RID: 39181 RVA: 0x0004A0E6 File Offset: 0x000482E6
		public unsafe List<RectTransform> customerEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600990E RID: 39182 RVA: 0x00275140 File Offset: 0x00273340
		// (set) Token: 0x0600990F RID: 39183 RVA: 0x0004A105 File Offset: 0x00048305
		public unsafe Dictionary<RectTransform, Customer> entryToCustomer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Customer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006723 RID: 26403
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04006724 RID: 26404
		private static readonly System.IntPtr NativeFieldInfoPtr_EntriesContainer;

		// Token: 0x04006725 RID: 26405
		private static readonly System.IntPtr NativeFieldInfoPtr_onCustomerSelected;

		// Token: 0x04006726 RID: 26406
		private static readonly System.IntPtr NativeFieldInfoPtr_customerEntries;

		// Token: 0x04006727 RID: 26407
		private static readonly System.IntPtr NativeFieldInfoPtr_entryToCustomer;

		// Token: 0x04006728 RID: 26408
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006729 RID: 26409
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400672A RID: 26410
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400672B RID: 26411
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400672C RID: 26412
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400672D RID: 26413
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400672E RID: 26414
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0;

		// Token: 0x0400672F RID: 26415
		private static readonly System.IntPtr NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0;

		// Token: 0x04006730 RID: 26416
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB1 RID: 2993
		[ObfuscatedName("ScheduleOne.UI.Phone.CustomerSelector+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF8B RID: 57227 RVA: 0x0035210C File Offset: 0x0035030C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr);
				CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, "customer");
				CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, 100682312);
				CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, 100682313);
			}

			// Token: 0x0600DF8C RID: 57228 RVA: 0x00352188 File Offset: 0x00350388
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF8D RID: 57229 RVA: 0x003521C4 File Offset: 0x003503C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274116, XrefRangeEnd = 274126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF8E RID: 57230 RVA: 0x0006C858 File Offset: 0x0006AA58
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004507 RID: 17671
			// (get) Token: 0x0600DF8F RID: 57231 RVA: 0x003521F8 File Offset: 0x003503F8
			// (set) Token: 0x0600DF90 RID: 57232 RVA: 0x0006C861 File Offset: 0x0006AA61
			public unsafe CustomerSelector __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004508 RID: 17672
			// (get) Token: 0x0600DF91 RID: 57233 RVA: 0x00352228 File Offset: 0x00350428
			// (set) Token: 0x0600DF92 RID: 57234 RVA: 0x0006C880 File Offset: 0x0006AA80
			public unsafe Customer customer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009625 RID: 38437
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009626 RID: 38438
			private static readonly System.IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x04009627 RID: 38439
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009628 RID: 38440
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0;
		}
	}
}
