using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000326 RID: 806
	public class Fixer : NPC
	{
		// Token: 0x06003B85 RID: 15237 RVA: 0x00135A70 File Offset: 0x00133C70
		// Note: this type is marked as 'beforefieldinit'.
		static Fixer()
		{
			Il2CppClassPointerStore<Fixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Fixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fixer>.NativeClassPtr);
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_1");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_2");
			Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "MAX_SIGNING_FEE");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_FEE_THRESHOLD");
			Fixer.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetingDialogue");
			Fixer.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetedVariable");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670319);
			Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670320);
			Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670321);
			Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670322);
			Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670323);
			Fixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670324);
			Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670325);
			Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670326);
			Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670327);
			Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670328);
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00135C08 File Offset: 0x00133E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147674, XrefRangeEnd = 147687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00135C44 File Offset: 0x00133E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147687, XrefRangeEnd = 147716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00135C78 File Offset: 0x00133E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147716, XrefRangeEnd = 147728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00135CAC File Offset: 0x00133EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147728, XrefRangeEnd = 147748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00135CE0 File Offset: 0x00133EE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147776, RefRangeEnd = 147779, XrefRangeStart = 147748, XrefRangeEnd = 147776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAdditionalSigningFee()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00135D10 File Offset: 0x00133F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147779, XrefRangeEnd = 147784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fixer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fixer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00135D4C File Offset: 0x00133F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00135D88 File Offset: 0x00133F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00135DC4 File Offset: 0x00133FC4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00135E00 File Offset: 0x00134000
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 147536, RefRangeEnd = 147540, XrefRangeStart = 147536, XrefRangeEnd = 147540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x0001E3FE File Offset: 0x0001C5FE
		public Fixer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003B91 RID: 15249 RVA: 0x00135E3C File Offset: 0x0013403C
		// (set) Token: 0x06003B92 RID: 15250 RVA: 0x0001E407 File Offset: 0x0001C607
		public unsafe static int ADDITIONAL_SIGNING_FEE_1
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&value));
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x00135E58 File Offset: 0x00134058
		// (set) Token: 0x06003B94 RID: 15252 RVA: 0x0001E415 File Offset: 0x0001C615
		public unsafe static int ADDITIONAL_SIGNING_FEE_2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&value));
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00135E74 File Offset: 0x00134074
		// (set) Token: 0x06003B96 RID: 15254 RVA: 0x0001E423 File Offset: 0x0001C623
		public unsafe static int MAX_SIGNING_FEE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&value));
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x00135E90 File Offset: 0x00134090
		// (set) Token: 0x06003B98 RID: 15256 RVA: 0x0001E431 File Offset: 0x0001C631
		public unsafe static int ADDITIONAL_FEE_THRESHOLD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x00135EAC File Offset: 0x001340AC
		// (set) Token: 0x06003B9A RID: 15258 RVA: 0x0001E43F File Offset: 0x0001C63F
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x00135EDC File Offset: 0x001340DC
		// (set) Token: 0x06003B9C RID: 15260 RVA: 0x0001E45E File Offset: 0x0001C65E
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x00135F04 File Offset: 0x00134104
		// (set) Token: 0x06003B9E RID: 15262 RVA: 0x0001E47D File Offset: 0x0001C67D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06003B9F RID: 15263 RVA: 0x00135F2C File Offset: 0x0013412C
		// (set) Token: 0x06003BA0 RID: 15264 RVA: 0x0001E498 File Offset: 0x0001C698
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SIGNING_FEE;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
