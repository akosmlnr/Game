using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000336 RID: 822
	public class Jeremy : NPC
	{
		// Token: 0x06003C4C RID: 15436 RVA: 0x001381BC File Offset: 0x001363BC
		// Note: this type is marked as 'beforefieldinit'.
		static Jeremy()
		{
			Il2CppClassPointerStore<Jeremy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Jeremy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy>.NativeClassPtr);
			Jeremy.NativeFieldInfoPtr_Dealership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Dealership");
			Jeremy.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Listings");
			Jeremy.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetingDialogue");
			Jeremy.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetedVariable");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670406);
			Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670407);
			Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670408);
			Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670409);
			Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670410);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670411);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670412);
			Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670413);
			Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670414);
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00138318 File Offset: 0x00136518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147827, XrefRangeEnd = 147840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00138354 File Offset: 0x00136554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147840, XrefRangeEnd = 147869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00138388 File Offset: 0x00136588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147869, XrefRangeEnd = 147881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x001383BC File Offset: 0x001365BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147881, XrefRangeEnd = 147901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x001383F0 File Offset: 0x001365F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147901, XrefRangeEnd = 147913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jeremy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x0013842C File Offset: 0x0013662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147913, XrefRangeEnd = 147914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x00138468 File Offset: 0x00136668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147914, XrefRangeEnd = 147915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x001384A4 File Offset: 0x001366A4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x001384E0 File Offset: 0x001366E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 147536, RefRangeEnd = 147540, XrefRangeStart = 147536, XrefRangeEnd = 147540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x0001E8A2 File Offset: 0x0001CAA2
		public Jeremy(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x0013851C File Offset: 0x0013671C
		// (set) Token: 0x06003C58 RID: 15448 RVA: 0x0001E8AB File Offset: 0x0001CAAB
		public unsafe Dealership Dealership
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealership>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0013854C File Offset: 0x0013674C
		// (set) Token: 0x06003C5A RID: 15450 RVA: 0x0001E8CA File Offset: 0x0001CACA
		public unsafe List<Jeremy.DealershipListing> Listings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Jeremy.DealershipListing>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x0013857C File Offset: 0x0013677C
		// (set) Token: 0x06003C5C RID: 15452 RVA: 0x0001E8E9 File Offset: 0x0001CAE9
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x001385AC File Offset: 0x001367AC
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x0001E908 File Offset: 0x0001CB08
		public unsafe string GreetedVariable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x001385D4 File Offset: 0x001367D4
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x0001E927 File Offset: 0x0001CB27
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x001385FC File Offset: 0x001367FC
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x0001E942 File Offset: 0x0001CB42
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040027C6 RID: 10182
		private static readonly System.IntPtr NativeFieldInfoPtr_Dealership;

		// Token: 0x040027C7 RID: 10183
		private static readonly System.IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x040027C8 RID: 10184
		private static readonly System.IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x040027C9 RID: 10185
		private static readonly System.IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x040027CA RID: 10186
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040027CB RID: 10187
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040027CC RID: 10188
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040027CD RID: 10189
		private static readonly System.IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040027CE RID: 10190
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x040027CF RID: 10191
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040027D4 RID: 10196
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000987 RID: 2439
		[System.Serializable]
		public class DealershipListing : Il2CppSystem.Object
		{
			// Token: 0x0600CC5B RID: 52315 RVA: 0x0031B2C0 File Offset: 0x003194C0
			// Note: this type is marked as 'beforefieldinit'.
			static DealershipListing()
			{
				Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "DealershipListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr);
				Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, "vehicleCode");
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670415);
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670416);
				Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670417);
			}

			// Token: 0x17003F5C RID: 16220
			// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x0031B33C File Offset: 0x0031953C
			public unsafe string vehicleName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 147814, RefRangeEnd = 147815, XrefRangeStart = 147809, XrefRangeEnd = 147814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17003F5D RID: 16221
			// (get) Token: 0x0600CC5D RID: 52317 RVA: 0x0031B374 File Offset: 0x00319574
			public unsafe float price
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 147820, RefRangeEnd = 147823, XrefRangeStart = 147815, XrefRangeEnd = 147820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x0600CC5E RID: 52318 RVA: 0x0031B3B0 File Offset: 0x003195B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147823, XrefRangeEnd = 147827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DealershipListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CC5F RID: 52319 RVA: 0x0006322B File Offset: 0x0006142B
			public DealershipListing(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F5B RID: 16219
			// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x0031B3EC File Offset: 0x003195EC
			// (set) Token: 0x0600CC61 RID: 52321 RVA: 0x00063234 File Offset: 0x00061434
			public unsafe string vehicleCode
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008A5D RID: 35421
			private static readonly System.IntPtr NativeFieldInfoPtr_vehicleCode;

			// Token: 0x04008A5E RID: 35422
			private static readonly System.IntPtr NativeMethodInfoPtr_get_vehicleName_Public_get_String_0;

			// Token: 0x04008A5F RID: 35423
			private static readonly System.IntPtr NativeMethodInfoPtr_get_price_Public_get_Single_0;

			// Token: 0x04008A60 RID: 35424
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
